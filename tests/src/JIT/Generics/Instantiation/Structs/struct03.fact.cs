using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Structs_struct03_struct03_
    {
        [Fact]
        public void _Instantiation_Structs_struct03_struct03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Structs\\struct03\\struct03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
