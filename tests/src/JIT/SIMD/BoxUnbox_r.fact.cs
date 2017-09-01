using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _BoxUnbox_r_BoxUnbox_r_
    {
        [OuterLoop]
        [Fact]
        public void _BoxUnbox_r_BoxUnbox_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\BoxUnbox_r\\BoxUnbox_r.cmd");
        }
    }
}
