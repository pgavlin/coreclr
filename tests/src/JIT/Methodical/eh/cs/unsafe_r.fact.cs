using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_cs_unsafe_r_unsafe_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_cs_unsafe_r_unsafe_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\cs\\unsafe_r\\unsafe_r.cmd");
        }
    }
}
