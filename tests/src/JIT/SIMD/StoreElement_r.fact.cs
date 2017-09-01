using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _StoreElement_r_StoreElement_r_
    {
        [OuterLoop]
        [Fact]
        public void _StoreElement_r_StoreElement_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\StoreElement_r\\StoreElement_r.cmd");
        }
    }
}
