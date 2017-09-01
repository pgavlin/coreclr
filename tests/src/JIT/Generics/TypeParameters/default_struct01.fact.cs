using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _TypeParameters_default_struct01_default_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _TypeParameters_default_struct01_default_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\TypeParameters\\default_struct01\\default_struct01.cmd");
        }
    }
}
