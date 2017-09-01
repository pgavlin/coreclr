using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_relcompat_r4_r8_inl__il_relcompat_r4_r8_inl_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_r4_r8_inl__il_relcompat_r4_r8_inl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_r4_r8_inl\\_il_relcompat_r4_r8_inl.cmd");
        }
    }
}
