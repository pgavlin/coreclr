using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _StoreElement_ro_StoreElement_ro_
    {
        [Fact]
        public void _StoreElement_ro_StoreElement_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\StoreElement_ro\\StoreElement_ro.cmd");
        }
    }
}
