using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_interface_struct01_interface_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_struct01_interface_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_struct01\\interface_struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
