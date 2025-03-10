// JavaScript for SPX Admin Dashboard
$(document).ready(function () {
    // Toggle dropdowns in sidebar
    $('.sidebar-nav .dropdown-toggle').click(function (e) {
        e.preventDefault();
        $(this).parent().toggleClass('open');
        $(this).parent().find('.dropdown-menu').slideToggle(200);
    });

    // Date range picker initialization
    $('.date-range-picker').daterangepicker({
        startDate: moment().subtract(7, 'days'),
        endDate: moment(),
        ranges: {
            'Today': [moment(), moment()],
            'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        }
    });

    // Refresh button functionality
    $('.btn-refresh').click(function () {
        // Add loading spinner
        $(this).find('i').addClass('fa-spin');

        // Simulate data refresh
        setTimeout(function () {
            $('.btn-refresh').find('i').removeClass('fa-spin');
            toastr.success('Data refreshed successfully');
        }, 1200);
    });

    // Info tooltips
    $('[data-toggle="tooltip"]').tooltip();

    // Initialize toastr notifications
    toastr.options = {
        "closeButton": true,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000"
    };
});