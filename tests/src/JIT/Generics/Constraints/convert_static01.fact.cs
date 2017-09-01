using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_convert_static01_convert_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_convert_static01_convert_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\convert_static01\\convert_static01.cmd");
        }
    }
}
