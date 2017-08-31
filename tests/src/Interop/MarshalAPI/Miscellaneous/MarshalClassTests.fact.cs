using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Miscellaneous_MarshalClassTests_MarshalClassTests_
    {
        [Fact]
        public void _Miscellaneous_MarshalClassTests_MarshalClassTests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Miscellaneous\\MarshalClassTests\\MarshalClassTests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
