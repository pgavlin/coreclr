using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_increment_longinc_longinc_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_increment_longinc_longinc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\increment\\longinc\\longinc.cmd");
        }
    }
}
