using CoreclrTestLib;
using Xunit;

namespace Interop_ArrayMarshalling
{
    class _ByValArray_MarshalArrayByValTest_MarshalArrayByValTest_
    {
        [Fact]
        public void _ByValArray_MarshalArrayByValTest_MarshalArrayByValTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\ArrayMarshalling\\ByValArray\\MarshalArrayByValTest\\MarshalArrayByValTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
