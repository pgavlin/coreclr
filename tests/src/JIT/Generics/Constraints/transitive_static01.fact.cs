using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_transitive_static01_transitive_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_transitive_static01_transitive_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\transitive_static01\\transitive_static01.cmd");
        }
    }
}
