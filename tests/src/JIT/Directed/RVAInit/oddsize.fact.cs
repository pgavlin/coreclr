using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_oddsize_oddsize_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_oddsize_oddsize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\oddsize\\oddsize.cmd");
        }
    }
}
