using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_Desktop__il_relthread_race__il_relthread_race_
    {
        [Fact]
        public void _tailcall_Desktop__il_relthread_race__il_relthread_race_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\Desktop\\_il_relthread-race\\_il_relthread-race.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
