using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_general_struct_instance01_general_struct_instance01_
    {
        [Fact]
        public void _Exceptions_general_struct_instance01_general_struct_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\general_struct_instance01\\general_struct_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
