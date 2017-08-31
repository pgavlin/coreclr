using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_struct_static01_struct_static01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_struct_static01_struct_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\struct_static01\\struct_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
