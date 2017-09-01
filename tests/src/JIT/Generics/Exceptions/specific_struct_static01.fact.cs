using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Exceptions_specific_struct_static01_specific_struct_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_struct_static01_specific_struct_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_struct_static01\\specific_struct_static01.cmd");
        }
    }
}
