using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_struct_instance01_struct_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_struct_instance01_struct_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\struct_instance01\\struct_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
