using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_cpobj_cpobj_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_cpobj_cpobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\cpobj\\cpobj.cmd");
        }
    }
}
