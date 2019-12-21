using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.ViewModel.Category
{
  public  class CategoryViewModel
    {
        #region [- ctor -]
        public CategoryViewModel()
        {
            Ref_CatgoryCrud = new Model.DomainModel.POCO.CategoryCrud();
        }
        #endregion
        public Model.DomainModel.POCO.CategoryCrud Ref_CatgoryCrud { get; set; }
        #region [-  FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_CatgoryCrud.Select();
        } 
        #endregion

    }
}
