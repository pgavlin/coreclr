using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_Dev10_846218_Dev10_846218_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_Dev10_846218_Dev10_846218_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\Dev10_846218\\Dev10_846218.cmd");
        }
    }
}
