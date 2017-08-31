using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_interface_struct02_interface_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_struct02_interface_struct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_struct02\\interface_struct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
