using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_relcompat_i4_i1__il_relcompat_i4_i1_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_i4_i1__il_relcompat_i4_i1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_i4_i1\\_il_relcompat_i4_i1.cmd");
        }
    }
}
