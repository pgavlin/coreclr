using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_interface_class02_interface_class02_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_class02_interface_class02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_class02\\interface_class02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
