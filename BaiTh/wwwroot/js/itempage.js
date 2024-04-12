<script>
    // Function to display products based on page number
    function displayProducts(pageNumber) {
        // Number of products per page
        var productsPerPage = 9;

        // Calculate start and end index for products on the current page
        var startIndex = (pageNumber - 1) * productsPerPage;
        var endIndex = startIndex + productsPerPage;

        // Hide all products
        $('#productList .category-item').hide();

        // Show products for the current page
        $('#productList .category-item').slice(startIndex, endIndex).show();
    }

    $(document).ready(function () {
        // Initial display: show products on page 1
        displayProducts(1);

        // Total number of products
        var totalProducts = $('#productList .category-item').length;

        // Calculate total number of pages
        var totalPages = Math.ceil(totalProducts / 9);

        // Create pagination buttons
        for (var i = 1; i <= totalPages; i++) {
            $('#pagination').append('<button class="btn btn-sm btn-page" data-page="' + i + '">' + i + '</button>');
        }

        // Event listener for pagination buttons
        $('#pagination').on('click', '.btn-page', function () {
            var pageNumber = $(this).data('page');
            displayProducts(pageNumber);
        });
    });
</script>