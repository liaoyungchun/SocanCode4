using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Table
    {
        private string name;
        private List<Model.Field> fields = new List<Field>();

        /// <summary>
        /// �������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// ���е�������
        /// </summary>
        public List<Model.Field> Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        /// <summary>
        /// ȡ���޸ĺ�ɾ���������ֶΣ���ѡ��ʶ�У�Ȼ����������
        /// </summary>
        public List<Model.Field> ConditionRows
        {
            get
            {
                //�鿴�Ƿ��б�ʶ���б�ʶ�򷵻����б�ʶ
                List<Model.Field> conditionRows = new List<Field>();
                foreach (Model.Field model in fields)
                {
                    if (model.IsIdentifier)
                    {
                        conditionRows.Add(model);
                    }
                }
                if (conditionRows.Count > 0)
                    return conditionRows;

                //�鿴�Ƿ����������������򷵻�����
                foreach (Model.Field model in fields)
                {
                    if (model.IsKeyField)
                    {
                        conditionRows.Add(model);
                    }
                }
                if (conditionRows.Count > 0)
                    return conditionRows;

                //���ޱ�ʶҲ���������򷵻ص�һ����
                if (fields.Count > 0)
                {
                    fields[0].IsKeyField = true;
                    conditionRows.Add(fields[0]);
                }

                return conditionRows;
            }
        }

        /// <summary>
        /// �Ƿ��б�ʶ������
        /// </summary>
        public bool HasConditonRow
        {
            get { return (ConditionRows != null && ConditionRows.Count > 0); }
        }

        /// <summary>
        /// ȡ���޸�ʱҪ�޸ĵ��ֶ�
        /// </summary>
        public List<Model.Field> UpdateRows
        {
            get
            {
                List<Model.Field> updateRows = new List<Field>();

                //û�б�ʶ������
                if (ConditionRows.Count == fields.Count)
                    return fields;

                //�Ա�ʶΪ�����ֶ�
                if (ConditionRows.Count == 1 && ConditionRows[0].IsIdentifier)
                {
                    foreach (Model.Field model in fields)
                    {
                        if (!model.IsIdentifier)
                            updateRows.Add(model);
                    }
                    return updateRows;
                }

                //������Ϊ�����ֶ�
                foreach (Model.Field model in fields)
                {
                    if (!model.IsIdentifier && !ConditionRows.Contains(model))
                        updateRows.Add(model);
                }
                return updateRows;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
