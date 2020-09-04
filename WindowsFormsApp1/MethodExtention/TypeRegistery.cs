using DevExpress.XtraEditors.Frames;


namespace SchoolApp
{
    public class TypeRegistery: StructureMap.Registry
    {

        public TypeRegistery()
        {
         
            For<ISetupProcess>().Use<SetupProcess>().Ctor<schooldbEntities>("db").Is(new schooldbEntities());
            For<IRfid_Class>().Use<RfidClass>().Ctor<schooldbEntities>("db").Is(new schooldbEntities());
            For<ISchoolProcess>().Use<SchoolProcess>().Ctor<schooldbEntities>("db").Is(new schooldbEntities());

        }
    }
}