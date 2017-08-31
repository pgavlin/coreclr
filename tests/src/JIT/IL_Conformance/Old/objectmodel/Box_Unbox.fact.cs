using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_Box_Unbox_Box_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_Box_Unbox_Box_Unbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\Box_Unbox\\Box_Unbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
