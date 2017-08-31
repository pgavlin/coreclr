using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_transitive_instance01_transitive_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_transitive_instance01_transitive_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\transitive_instance01\\transitive_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
