using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_cs_unsafe_d_unsafe_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_cs_unsafe_d_unsafe_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\cs\\unsafe_d\\unsafe_d.cmd");
        }
    }
}
