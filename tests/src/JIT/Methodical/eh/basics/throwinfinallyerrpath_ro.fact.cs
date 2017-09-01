using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwinfinallyerrpath_ro_throwinfinallyerrpath_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpath_ro_throwinfinallyerrpath_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpath_ro\\throwinfinallyerrpath_ro.cmd");
        }
    }
}
