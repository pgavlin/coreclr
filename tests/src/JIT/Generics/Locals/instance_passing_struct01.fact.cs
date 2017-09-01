using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Locals_instance_passing_struct01_instance_passing_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Locals_instance_passing_struct01_instance_passing_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Locals\\instance_passing_struct01\\instance_passing_struct01.cmd");
        }
    }
}
