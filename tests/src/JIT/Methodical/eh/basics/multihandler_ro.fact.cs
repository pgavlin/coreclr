using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_multihandler_ro_multihandler_ro_
    {
        [Fact]
        public void _eh_basics_multihandler_ro_multihandler_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\multihandler_ro\\multihandler_ro.cmd");
        }
    }
}
