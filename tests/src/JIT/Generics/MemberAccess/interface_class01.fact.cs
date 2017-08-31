using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_interface_class01_interface_class01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_class01_interface_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_class01\\interface_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
