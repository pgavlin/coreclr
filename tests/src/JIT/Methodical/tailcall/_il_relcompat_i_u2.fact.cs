using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_relcompat_i_u2__il_relcompat_i_u2_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_i_u2__il_relcompat_i_u2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_i_u2\\_il_relcompat_i_u2.cmd");
        }
    }
}
