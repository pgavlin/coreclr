using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_ldobj_ldobj_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldobj_ldobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldobj\\ldobj.cmd");
        }
    }
}
