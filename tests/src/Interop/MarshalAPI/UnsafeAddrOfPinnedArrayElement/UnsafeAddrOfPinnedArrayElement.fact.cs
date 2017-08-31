using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _UnsafeAddrOfPinnedArrayElement_UnsafeAddrOfPinnedArrayElement_UnsafeAddrOfPinnedArrayElement_
    {
        [OuterLoop]
        [Fact]
        public void _UnsafeAddrOfPinnedArrayElement_UnsafeAddrOfPinnedArrayElement_UnsafeAddrOfPinnedArrayElement_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\UnsafeAddrOfPinnedArrayElement\\UnsafeAddrOfPinnedArrayElement\\UnsafeAddrOfPinnedArrayElement.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
