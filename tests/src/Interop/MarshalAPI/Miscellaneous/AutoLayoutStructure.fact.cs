using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Miscellaneous_AutoLayoutStructure_AutoLayoutStructure_
    {
        [Fact]
        public void _Miscellaneous_AutoLayoutStructure_AutoLayoutStructure_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Miscellaneous\\AutoLayoutStructure\\AutoLayoutStructure.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
