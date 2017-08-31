using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _GetExceptionForHR_GetExceptionForHR_GetExceptionForHR_
    {
        [Fact]
        public void _GetExceptionForHR_GetExceptionForHR_GetExceptionForHR_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetExceptionForHR\\GetExceptionForHR\\GetExceptionForHR.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
