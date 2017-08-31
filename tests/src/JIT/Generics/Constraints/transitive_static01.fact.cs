using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_transitive_static01_transitive_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_transitive_static01_transitive_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\transitive_static01\\transitive_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
