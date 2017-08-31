using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    class _Bool_BoolTest_BoolTest_
    {
        [OuterLoop]
        [Fact]
        public void _Bool_BoolTest_BoolTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\Bool\\BoolTest\\BoolTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
