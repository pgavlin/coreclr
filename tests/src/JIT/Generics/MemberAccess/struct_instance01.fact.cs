using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _MemberAccess_struct_instance01_struct_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_struct_instance01_struct_instance01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\struct_instance01\\struct_instance01.cmd");
        }
    }
}
