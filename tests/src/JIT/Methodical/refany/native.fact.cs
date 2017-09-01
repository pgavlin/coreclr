using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany_native_native_
    {
        [OuterLoop]
        [Fact]
        public void _refany_native_native_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\native\\native.cmd");
        }
    }
}
