var productController = function () {
    this.initialize = function () {
        loadCategories();
        loadData();
        registerEvents();
    }

    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            nui.configs.pageSize = $(this).val();
            nui.configs.pageIndex = 1;
            loadData(true);
        });
        $('#btn-search').on('click', function () {
            loadData(true);
        });
        $('#keyWord').on('keypress', function (e) {
            if (e.which === 13) {
                loadData(true);
            }
        });
        $('#category').on('change', function () {
            loadData(true);
        });
    }
    function loadCategories() {
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllCategories',
            dataType: 'json',
            success: function (response) {
                var render = "<option value=''>--Select category--</option>";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.Id + "'>" + item.Name + "</option>"
                });
                $('#category').html(render);
            },
            error: function (status) {
                console.log(status);
                nui.notify('Cannot loading product category data', 'error');
            }
        });
    }
    function loadData(isPageChanged) {
        var template = $('#tbl-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: $('#category').val(),
                keyword: $('#keyWord').val(),
                page: nui.configs.pageIndex,
                pageSize: nui.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (response) {
                console.log(response);
                $.each(response.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        //Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: nui.formatNumber(item.Price, 0),
                        CreatedDate: nui.dateTimeFormatJson(item.DateCreated),
                        Status: nui.getStatus(item.Status)
                    });
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log(status);
                nui.notify('Cannot loading data', 'error');
            }
        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / nui.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'First',
            prev: 'Prev',
            next: 'Next',
            last: 'Last',
            onPageClick: function (event, p) {
                nui.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}