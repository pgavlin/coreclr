using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Instantiation_Structs_struct02_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_Structs_struct02_struct02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Structs\\struct02\\struct02.cmd");
        }
    }
}
