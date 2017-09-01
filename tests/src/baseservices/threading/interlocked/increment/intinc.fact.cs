using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_increment_intinc_intinc_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_increment_intinc_intinc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\increment\\intinc\\intinc.cmd");
        }
    }
}
