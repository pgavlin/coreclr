using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_transitive_instance01_transitive_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_transitive_instance01_transitive_instance01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\transitive_instance01\\transitive_instance01.cmd");
        }
    }
}
