using CoreclrTestLib;
using Xunit;

namespace Interop_PrimitiveMarshalling
{
    public class _Bool_BoolTest_BoolTest_
    {
        [OuterLoop]
        [Fact]
        public void _Bool_BoolTest_BoolTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\PrimitiveMarshalling\\Bool\\BoolTest\\BoolTest.cmd");
        }
    }
}
