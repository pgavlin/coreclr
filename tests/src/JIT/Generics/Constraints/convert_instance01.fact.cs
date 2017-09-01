using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_convert_instance01_convert_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_convert_instance01_convert_instance01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\convert_instance01\\convert_instance01.cmd");
        }
    }
}
