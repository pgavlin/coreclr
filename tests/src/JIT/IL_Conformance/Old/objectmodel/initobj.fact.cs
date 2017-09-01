using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_initobj_initobj_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_initobj_initobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\initobj\\initobj.cmd");
        }
    }
}
