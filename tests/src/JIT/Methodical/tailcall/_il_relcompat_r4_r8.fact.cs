using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_relcompat_r4_r8__il_relcompat_r4_r8_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_r4_r8__il_relcompat_r4_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_r4_r8\\_il_relcompat_r4_r8.cmd");
        }
    }
}
