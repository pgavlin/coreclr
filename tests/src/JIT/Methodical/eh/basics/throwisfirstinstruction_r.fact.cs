using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwisfirstinstruction_r_throwisfirstinstruction_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwisfirstinstruction_r_throwisfirstinstruction_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwisfirstinstruction_r\\throwisfirstinstruction_r.cmd");
        }
    }
}
