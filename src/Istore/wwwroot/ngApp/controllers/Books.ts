
namespace Istore.Controllers {
    
    export class BookController {

        private bookResource;
        public books;
        public book;

        public getBooks() {

            this.books = this.bookResource.query();
        }

        constructor(private $resource: angular.resource.IResourceService) {
            this.bookResource = $resource("/api/books");
            this.getBooks();

        }
        public save() {
            this.bookResource.save(this.book).$promise.then(() => {
                console.log(this.book);
                this.book = null
                this.getBooks();

            })

        }

    }
}
