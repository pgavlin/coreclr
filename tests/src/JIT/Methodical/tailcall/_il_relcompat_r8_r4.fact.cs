using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_relcompat_r8_r4__il_relcompat_r8_r4_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_r8_r4__il_relcompat_r8_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_r8_r4\\_il_relcompat_r8_r4.cmd");
        }
    }
}
