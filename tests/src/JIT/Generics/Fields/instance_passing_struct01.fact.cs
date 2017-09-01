using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Fields_instance_passing_struct01_instance_passing_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Fields_instance_passing_struct01_instance_passing_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\instance_passing_struct01\\instance_passing_struct01.cmd");
        }
    }
}
