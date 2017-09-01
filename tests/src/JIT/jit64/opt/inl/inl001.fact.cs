using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_inl_inl001_inl001_
    {
        [OuterLoop]
        [Fact]
        public void _opt_inl_inl001_inl001_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\inl\\inl001\\inl001.cmd");
        }
    }
}
