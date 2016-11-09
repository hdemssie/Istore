
namespace Istore.Controllers {

    export class HomeController {


        private clotheResource;
        public clothes;
        public clothe;

        public getClothes() {

            this.clothes = this.clotheResource.query();
        }

        constructor(private $resource: angular.resource.IResourceService) {
            this.clotheResource = $resource("/api/clothes");
            this.getClothes();

        }
        public save() {
            this.clotheResource.save(this.clothe).$promise.then(() => {
                this.clothe = null
                this.getClothes();

            })

        }

    }

}
