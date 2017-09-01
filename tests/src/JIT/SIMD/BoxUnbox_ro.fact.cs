using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _BoxUnbox_ro_BoxUnbox_ro_
    {
        [Fact]
        public void _BoxUnbox_ro_BoxUnbox_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\BoxUnbox_ro\\BoxUnbox_ro.cmd");
        }
    }
}
