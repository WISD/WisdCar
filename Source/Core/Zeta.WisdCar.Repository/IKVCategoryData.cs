using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IKVCategoryData
    {
        /// <summary>
        /// ��ȡ��������б�
        /// </summary>
        /// <returns></returns>
        DataSet GetAllCategorys();

        /// <summary>
        /// ����ID��ȡ���
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        KVCategoryPO GetCategoryByID(int categoryID);

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="category"></param>
        void AddCategory(KVCategoryPO category);

        /// <summary>
        /// �޸����
        /// </summary>
        /// <param name="category"></param>
        void EditCategory(KVCategoryPO category);

        /// <summary>
        /// ɾ�����
        /// </summary>
        /// <param name="id"></param>
        void DelCategory(int id);
    }
}
